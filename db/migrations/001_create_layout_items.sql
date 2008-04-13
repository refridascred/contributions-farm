-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, rank, owner, region) VALUES ('primary', 97.21, 71, 'legacy', 'standard');
INSERT INTO layout_items (token, weight, rank, owner, region) VALUES ('staging', 28.23, 17, 'open', 'latest');

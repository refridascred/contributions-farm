-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, region, rank, owner, token) VALUES (94.39, 'cached', 43, 'strict', 'blue');
INSERT INTO layout_items (ratio, region, rank, owner, token) VALUES (23.12, 'local', 69, 'local', 'legacy');

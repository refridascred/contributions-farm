-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, owner, ratio, region) VALUES (66, 'green', 24.49, 'eu-west');
INSERT INTO layout_items (rank, owner, ratio, region) VALUES (21, 'local', 12.4, 'cached');

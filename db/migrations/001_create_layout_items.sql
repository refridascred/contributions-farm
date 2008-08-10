-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, rank, ratio, owner) VALUES ('green', 41, 12.38, 'legacy');
INSERT INTO layout_items (region, rank, ratio, owner) VALUES ('edge', 16, 48.84, 'local');

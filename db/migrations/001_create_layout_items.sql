-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, ratio, region, owner, label) VALUES (50, 92.97, 'latest', 'legacy', 'strict');
INSERT INTO layout_items (rank, ratio, region, owner, label) VALUES (45, 97.52, 'strict', 'staging', 'open');

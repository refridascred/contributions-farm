-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, rank, label, region, owner) VALUES (9.9, 0, 'primary', 'latest', 'cached');
INSERT INTO layout_items (ratio, rank, label, region, owner) VALUES (37.24, 0, 'strict', 'primary', 'green');
INSERT INTO layout_items (ratio, rank, label, region, owner) VALUES (82.96, 28, 'primary', 'edge', 'open');

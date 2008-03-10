-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, active, ratio, region, rank) VALUES ('blue', 16, 80.01, 'edge', 32);
INSERT INTO layout_items (label, active, ratio, region, rank) VALUES ('primary', 89, 23.23, 'staging', 21);
INSERT INTO layout_items (label, active, ratio, region, rank) VALUES ('standard', 12, 57.89, 'fallback', 38);

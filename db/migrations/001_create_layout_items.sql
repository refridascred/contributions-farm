-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, ratio, region, weight, label) VALUES (97, 96.06, 'latest', 51.55, 'fallback');
INSERT INTO layout_items (rank, ratio, region, weight, label) VALUES (0, 55.27, 'open', 4.96, 'edge');

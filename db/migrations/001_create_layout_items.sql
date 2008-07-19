-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, rank, label) VALUES (90.92, 39, 'edge');
INSERT INTO layout_items (ratio, rank, label) VALUES (39.41, 35, 'green');
INSERT INTO layout_items (ratio, rank, label) VALUES (13.15, 76, 'standard');

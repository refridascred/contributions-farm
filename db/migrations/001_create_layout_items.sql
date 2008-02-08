-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, rank, active, ratio, label) VALUES (44.89, 71, 19, 41.05, 'legacy');
INSERT INTO layout_items (weight, rank, active, ratio, label) VALUES (90.94, 97, 49, 6.1, 'eu-west');
INSERT INTO layout_items (weight, rank, active, ratio, label) VALUES (53.7, 89, 58, 23.72, 'latest');

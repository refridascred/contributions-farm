-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, rank, active, weight) VALUES (53.57, 23, 40, 98.75);
INSERT INTO layout_items (ratio, rank, active, weight) VALUES (61.8, 10, 82, 43.77);
INSERT INTO layout_items (ratio, rank, active, weight) VALUES (21.07, 42, 36, 10.82);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, weight, level, rank) VALUES ('blue', 24.91, 74, 63);
INSERT INTO layout_items (label, weight, level, rank) VALUES ('edge', 65.07, 69, 38);

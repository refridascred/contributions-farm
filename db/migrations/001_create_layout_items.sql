-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight, active) VALUES (96, 63.35, 19);
INSERT INTO layout_items (rank, weight, active) VALUES (81, 72.94, 44);
INSERT INTO layout_items (rank, weight, active) VALUES (26, 54.77, 61);

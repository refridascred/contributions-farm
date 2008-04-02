-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, active, ratio, rank, owner) VALUES (98.29, 89, 5.81, 90, 'primary');
INSERT INTO layout_items (weight, active, ratio, rank, owner) VALUES (98.36, 74, 22.46, 39, 'legacy');
INSERT INTO layout_items (weight, active, ratio, rank, owner) VALUES (1.76, 24, 42.39, 61, 'green');

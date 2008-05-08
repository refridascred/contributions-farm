-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, label, count, weight) VALUES (63, 'latest', 2, 65.71);
INSERT INTO layout_items (rank, label, count, weight) VALUES (44, 'local', 24, 23.64);
INSERT INTO layout_items (rank, label, count, weight) VALUES (30, 'stable', 67, 70.62);

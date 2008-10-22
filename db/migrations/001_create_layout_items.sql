-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, weight, rank, count, active) VALUES ('cached', 38.42, 78, 10, 65);
INSERT INTO layout_items (owner, weight, rank, count, active) VALUES ('latest', 85.57, 56, 5, 25);

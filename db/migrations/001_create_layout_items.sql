-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, rank, active, score) VALUES (22.56, 23, 74, 59.47);
INSERT INTO layout_items (weight, rank, active, score) VALUES (17.47, 87, 47, 68.65);
INSERT INTO layout_items (weight, rank, active, score) VALUES (84.55, 58, 0, 25.74);

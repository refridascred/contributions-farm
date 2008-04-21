-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, count, active, owner, rank) VALUES (57.05, 33, 30, 'stable', 8);
INSERT INTO layout_items (weight, count, active, owner, rank) VALUES (0.66, 34, 28, 'blue', 65);
INSERT INTO layout_items (weight, count, active, owner, rank) VALUES (35.86, 7, 90, 'local', 84);

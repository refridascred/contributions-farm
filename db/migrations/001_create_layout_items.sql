-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, score, count, active) VALUES (24, 48.97, 71, 39);
INSERT INTO layout_items (rank, score, count, active) VALUES (0, 83.62, 53, 48);
INSERT INTO layout_items (rank, score, count, active) VALUES (28, 32.36, 95, 91);

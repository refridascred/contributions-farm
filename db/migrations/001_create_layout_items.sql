-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, score, ratio, active) VALUES (41, 63.14, 90.59, 88);
INSERT INTO layout_items (rank, score, ratio, active) VALUES (73, 68.59, 61.26, 67);
INSERT INTO layout_items (rank, score, ratio, active) VALUES (69, 60.27, 44.66, 50);

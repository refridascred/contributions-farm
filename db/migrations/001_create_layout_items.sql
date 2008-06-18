-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, score, active) VALUES (14, 12, 32.27, 37);
INSERT INTO layout_items (level, rank, score, active) VALUES (57, 65, 36.21, 44);
INSERT INTO layout_items (level, rank, score, active) VALUES (29, 75, 11.49, 96);

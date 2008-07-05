-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, score, weight, rank, active) VALUES (9, 66.32, 32.56, 54, 9);
INSERT INTO layout_items (level, score, weight, rank, active) VALUES (96, 45.66, 12.84, 24, 36);

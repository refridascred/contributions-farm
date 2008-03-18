-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, ratio, active, level) VALUES (81.53, 39.68, 46, 36);
INSERT INTO layout_items (score, ratio, active, level) VALUES (62.53, 74.89, 81, 47);

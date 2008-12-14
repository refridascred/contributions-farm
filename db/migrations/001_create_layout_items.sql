-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, label, score, weight, level) VALUES (62, 'fallback', 32.71, 8.57, 49);
INSERT INTO layout_items (active, label, score, weight, level) VALUES (72, 'local', 9.48, 83.11, 35);

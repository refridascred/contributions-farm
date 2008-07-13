-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, count, owner, score) VALUES (80.95, 21, 'primary', 11.71);
INSERT INTO layout_items (weight, count, owner, score) VALUES (97.42, 7, 'open', 93.73);

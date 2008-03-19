-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, score, token, weight) VALUES (94, 15.98, 'fallback', 53.84);
INSERT INTO layout_items (active, score, token, weight) VALUES (16, 95.21, 'staging', 27.96);
INSERT INTO layout_items (active, score, token, weight) VALUES (85, 89.72, 'local', 52.01);

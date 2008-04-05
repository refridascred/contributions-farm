-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, token, level, count, state) VALUES (89.41, 'eu-west', 3, 22, 'standard');
INSERT INTO layout_items (score, token, level, count, state) VALUES (64.75, 'eu-west', 62, 92, 'eu-west');
INSERT INTO layout_items (score, token, level, count, state) VALUES (78.99, 'legacy', 30, 14, 'blue');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, score, token) VALUES (60, 97.49, 'legacy');
INSERT INTO layout_items (level, score, token) VALUES (8, 70.65, 'standard');
INSERT INTO layout_items (level, score, token) VALUES (12, 83.55, 'cached');

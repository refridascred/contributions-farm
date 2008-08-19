-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, score, label, active) VALUES ('fallback', 6.4, 'legacy', 3);
INSERT INTO layout_items (token, score, label, active) VALUES ('cached', 70.94, 'fallback', 0);

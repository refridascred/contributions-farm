-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, score, active) VALUES ('legacy', 'cached', 85.07, 12);
INSERT INTO layout_items (label, token, score, active) VALUES ('open', 'fallback', 29.56, 59);
INSERT INTO layout_items (label, token, score, active) VALUES ('stable', 'eu-west', 36.63, 67);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, token, score, count) VALUES ('fallback', 'primary', 0.09, 72);
INSERT INTO layout_items (owner, token, score, count) VALUES ('open', 'fallback', 12.06, 33);
INSERT INTO layout_items (owner, token, score, count) VALUES ('open', 'edge', 81.25, 46);

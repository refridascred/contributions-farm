-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, label, token, score, state) VALUES (71, 'stable', 'fallback', 41.89, 'staging');
INSERT INTO layout_items (count, label, token, score, state) VALUES (73, 'latest', 'strict', 98.9, 'primary');

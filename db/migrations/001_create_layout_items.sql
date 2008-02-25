-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, owner, token, label) VALUES (76.7, 'green', 'local', 'edge');
INSERT INTO layout_items (score, owner, token, label) VALUES (58.48, 'latest', 'strict', 'green');

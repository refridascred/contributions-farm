-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, score, token) VALUES ('eu-west', 20.94, 'green');
INSERT INTO layout_items (label, score, token) VALUES ('open', 89.69, 'strict');

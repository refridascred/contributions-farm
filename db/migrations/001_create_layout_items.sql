-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, label, score) VALUES ('open', 'latest', 45.09);
INSERT INTO layout_items (token, label, score) VALUES ('cached', 'standard', 6.5);
INSERT INTO layout_items (token, label, score) VALUES ('green', 'open', 90.5);

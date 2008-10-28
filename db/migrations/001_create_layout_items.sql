-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, count, score) VALUES ('green', 'primary', 57, 45.59);
INSERT INTO layout_items (label, token, count, score) VALUES ('open', 'eu-west', 86, 93.83);
INSERT INTO layout_items (label, token, count, score) VALUES ('edge', 'staging', 90, 76.33);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, label, count) VALUES ('green', 'cached', 2);
INSERT INTO layout_items (token, label, count) VALUES ('latest', 'standard', 16);
INSERT INTO layout_items (token, label, count) VALUES ('open', 'primary', 87);

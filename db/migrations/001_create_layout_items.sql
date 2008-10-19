-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, weight) VALUES ('legacy', 'eu-west', 59.43);
INSERT INTO layout_items (label, token, weight) VALUES ('green', 'fallback', 58.95);

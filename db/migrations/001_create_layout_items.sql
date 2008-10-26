-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, active, label, count) VALUES ('green', 80, 'blue', 67);
INSERT INTO layout_items (token, active, label, count) VALUES ('green', 13, 'blue', 21);
INSERT INTO layout_items (token, active, label, count) VALUES ('primary', 54, 'open', 65);

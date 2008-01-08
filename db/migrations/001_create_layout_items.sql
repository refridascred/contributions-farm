-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, label, count) VALUES ('strict', 'green', 78);
INSERT INTO layout_items (token, label, count) VALUES ('green', 'legacy', 70);
INSERT INTO layout_items (token, label, count) VALUES ('primary', 'latest', 71);

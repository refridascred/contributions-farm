-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (label, count) VALUES ('fallback', 61);
INSERT INTO layout_items (label, count) VALUES ('fallback', 0);
INSERT INTO layout_items (label, count) VALUES ('fallback', 1);

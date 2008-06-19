-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, level, token, count) VALUES ('edge', 93, 'latest', 1);
INSERT INTO layout_items (label, level, token, count) VALUES ('cached', 28, 'standard', 84);

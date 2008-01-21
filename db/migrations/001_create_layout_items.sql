-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, count, label) VALUES ('staging', 40, 'strict');
INSERT INTO layout_items (region, count, label) VALUES ('local', 59, 'cached');
INSERT INTO layout_items (region, count, label) VALUES ('staging', 13, 'green');

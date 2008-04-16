-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label) VALUES (17.94, 'fallback');
INSERT INTO layout_items (ratio, label) VALUES (67.06, 'strict');
INSERT INTO layout_items (ratio, label) VALUES (76.8, 'open');

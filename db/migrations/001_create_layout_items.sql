-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label, token) VALUES (51.31, 'standard', 'staging');
INSERT INTO layout_items (ratio, label, token) VALUES (14.86, 'strict', 'standard');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, owner) VALUES ('open', 15.11, 'primary');
INSERT INTO layout_items (label, ratio, owner) VALUES ('legacy', 44.7, 'cached');
INSERT INTO layout_items (label, ratio, owner) VALUES ('strict', 96.83, 'local');

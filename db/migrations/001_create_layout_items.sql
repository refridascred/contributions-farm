-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, level, region) VALUES ('legacy', 57, 'standard');
INSERT INTO layout_items (label, level, region) VALUES ('blue', 0, 'staging');
INSERT INTO layout_items (label, level, region) VALUES ('strict', 58, 'local');

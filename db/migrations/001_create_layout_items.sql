-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region) VALUES ('latest', 'local');
INSERT INTO layout_items (label, region) VALUES ('legacy', 'cached');
INSERT INTO layout_items (label, region) VALUES ('eu-west', 'edge');

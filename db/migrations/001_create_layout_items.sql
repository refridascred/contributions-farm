-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, active, region) VALUES ('blue', 34, 'primary');
INSERT INTO layout_items (label, active, region) VALUES ('eu-west', 10, 'eu-west');

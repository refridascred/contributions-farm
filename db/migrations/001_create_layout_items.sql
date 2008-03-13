-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, region, owner) VALUES (37, 'strict', 'eu-west');
INSERT INTO layout_items (active, region, owner) VALUES (14, 'standard', 'stable');
INSERT INTO layout_items (active, region, owner) VALUES (23, 'strict', 'stable');

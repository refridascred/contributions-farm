-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, region, active, count) VALUES ('open', 'staging', 43, 51);
INSERT INTO layout_items (state, region, active, count) VALUES ('staging', 'eu-west', 1, 83);
INSERT INTO layout_items (state, region, active, count) VALUES ('strict', 'open', 35, 98);

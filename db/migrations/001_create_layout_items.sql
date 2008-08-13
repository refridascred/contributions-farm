-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, region, label, count) VALUES ('primary', 'eu-west', 'eu-west', 59);
INSERT INTO layout_items (state, region, label, count) VALUES ('primary', 'eu-west', 'eu-west', 49);

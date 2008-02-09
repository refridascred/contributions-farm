-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, count, region, state) VALUES ('eu-west', 91, 'green', 'green');
INSERT INTO layout_items (label, count, region, state) VALUES ('fallback', 62, 'legacy', 'edge');
INSERT INTO layout_items (label, count, region, state) VALUES ('primary', 59, 'cached', 'edge');

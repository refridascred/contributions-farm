-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, count, state) VALUES ('cached', 9, 'open');
INSERT INTO layout_items (region, count, state) VALUES ('primary', 70, 'open');
INSERT INTO layout_items (region, count, state) VALUES ('edge', 4, 'legacy');

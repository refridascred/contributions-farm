-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, label, state) VALUES ('cached', 'staging', 'fallback');
INSERT INTO layout_items (region, label, state) VALUES ('standard', 'cached', 'open');
INSERT INTO layout_items (region, label, state) VALUES ('green', 'standard', 'blue');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, label, level) VALUES ('standard', 'blue', 43);
INSERT INTO layout_items (state, label, level) VALUES ('staging', 'staging', 98);
INSERT INTO layout_items (state, label, level) VALUES ('staging', 'cached', 51);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, weight, state) VALUES ('primary', 18.55, 'strict');
INSERT INTO layout_items (label, weight, state) VALUES ('legacy', 52.78, 'fallback');

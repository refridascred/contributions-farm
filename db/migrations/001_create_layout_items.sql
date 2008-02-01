-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, count, label, level, weight) VALUES ('cached', 77, 'open', 91, 63.38);
INSERT INTO layout_items (state, count, label, level, weight) VALUES ('legacy', 63, 'strict', 83, 44.59);
INSERT INTO layout_items (state, count, label, level, weight) VALUES ('green', 43, 'staging', 20, 21.88);

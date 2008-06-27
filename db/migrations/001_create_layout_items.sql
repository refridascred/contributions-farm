-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, label, weight, owner, level) VALUES ('legacy', 'eu-west', 44.22, 'open', 36);
INSERT INTO layout_items (state, label, weight, owner, level) VALUES ('staging', 'edge', 3.07, 'strict', 65);
INSERT INTO layout_items (state, label, weight, owner, level) VALUES ('strict', 'cached', 23.42, 'stable', 41);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, label, ratio) VALUES ('blue', 'cached', 95.01);
INSERT INTO layout_items (state, label, ratio) VALUES ('latest', 'stable', 6.23);
INSERT INTO layout_items (state, label, ratio) VALUES ('latest', 'eu-west', 88.99);

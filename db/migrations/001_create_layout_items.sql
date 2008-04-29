-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, label, ratio, state, weight) VALUES (25.3, 'primary', 72.07, 'legacy', 22.46);
INSERT INTO layout_items (score, label, ratio, state, weight) VALUES (22.86, 'blue', 65.08, 'eu-west', 90.91);

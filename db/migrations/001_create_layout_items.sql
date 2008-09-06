-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, score, state, ratio, label) VALUES ('standard', 52.87, 'blue', 65.17, 'primary');
INSERT INTO layout_items (owner, score, state, ratio, label) VALUES ('primary', 80.54, 'blue', 51.96, 'eu-west');

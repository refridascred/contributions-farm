-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, rank, region, active) VALUES ('eu-west', 11, 'standard', 11);
INSERT INTO layout_items (state, rank, region, active) VALUES ('edge', 89, 'eu-west', 33);
INSERT INTO layout_items (state, rank, region, active) VALUES ('primary', 47, 'fallback', 25);

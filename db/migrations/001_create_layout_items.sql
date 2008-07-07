-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, state, ratio) VALUES ('eu-west', 'fallback', 78.42);
INSERT INTO layout_items (label, state, ratio) VALUES ('stable', 'standard', 62.15);
INSERT INTO layout_items (label, state, ratio) VALUES ('staging', 'staging', 85.61);

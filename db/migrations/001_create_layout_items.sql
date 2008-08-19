-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, label, region) VALUES ('fallback', 'fallback', 'strict');
INSERT INTO layout_items (owner, label, region) VALUES ('eu-west', 'stable', 'open');
INSERT INTO layout_items (owner, label, region) VALUES ('primary', 'cached', 'standard');
